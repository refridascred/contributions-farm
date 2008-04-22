-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, region, active, level, owner) VALUES ('eu-west', 'local', 70, 50, 'strict');
INSERT INTO layout_items (state, region, active, level, owner) VALUES ('primary', 'blue', 86, 8, 'edge');
INSERT INTO layout_items (state, region, active, level, owner) VALUES ('open', 'fallback', 76, 61, 'fallback');
