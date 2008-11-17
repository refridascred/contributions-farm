-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, label, score, token, state) VALUES ('fallback', 'stable', 9.47, 'blue', 'staging');
INSERT INTO layout_items (region, label, score, token, state) VALUES ('fallback', 'edge', 15.02, 'stable', 'strict');
