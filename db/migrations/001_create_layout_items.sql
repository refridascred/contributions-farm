-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, region, owner, weight) VALUES ('green', 'primary', 'cached', 23.17);
INSERT INTO layout_items (label, region, owner, weight) VALUES ('green', 'staging', 'edge', 15.04);
