-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, label) VALUES (86.65, 'primary', 'cached');
INSERT INTO layout_items (score, region, label) VALUES (20.15, 'local', 'eu-west');
INSERT INTO layout_items (score, region, label) VALUES (2.15, 'edge', 'standard');
