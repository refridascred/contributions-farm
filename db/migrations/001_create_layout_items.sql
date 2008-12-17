-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, token, region, ratio, state) VALUES (93, 'stable', 'local', 5.22, 'edge');
INSERT INTO layout_items (level, token, region, ratio, state) VALUES (4, 'fallback', 'open', 35.34, 'strict');
