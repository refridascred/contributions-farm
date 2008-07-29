-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, region, count, ratio, state) VALUES ('local', 'edge', 14, 34.68, 'fallback');
INSERT INTO layout_items (owner, region, count, ratio, state) VALUES ('open', 'strict', 65, 98.06, 'local');
INSERT INTO layout_items (owner, region, count, ratio, state) VALUES ('primary', 'primary', 92, 32.43, 'open');
