-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, state, region, score, label) VALUES (59.71, 'stable', 'staging', 84.22, 'eu-west');
INSERT INTO layout_items (weight, state, region, score, label) VALUES (13.72, 'fallback', 'cached', 14.76, 'legacy');
INSERT INTO layout_items (weight, state, region, score, label) VALUES (16.62, 'blue', 'open', 41.19, 'edge');
