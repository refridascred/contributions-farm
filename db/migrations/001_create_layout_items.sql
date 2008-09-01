-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, token, score, region, state) VALUES ('strict', 'stable', 61.37, 'primary', 'edge');
INSERT INTO layout_items (label, token, score, region, state) VALUES ('local', 'edge', 66.08, 'latest', 'blue');
