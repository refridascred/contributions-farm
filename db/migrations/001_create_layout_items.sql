-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, score, label) VALUES ('eu-west', 63.6, 'edge');
INSERT INTO layout_items (region, score, label) VALUES ('cached', 19.91, 'standard');
INSERT INTO layout_items (region, score, label) VALUES ('green', 81.54, 'open');
