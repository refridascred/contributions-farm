-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, label, region, owner) VALUES (31.75, 'staging', 'latest', 'edge');
INSERT INTO layout_items (weight, label, region, owner) VALUES (5.83, 'cached', 'staging', 'legacy');
