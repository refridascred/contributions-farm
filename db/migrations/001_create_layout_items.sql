-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, owner, score, region) VALUES (91.65, 'blue', 6.23, 'staging');
INSERT INTO layout_items (weight, owner, score, region) VALUES (41.14, 'staging', 43.26, 'primary');
INSERT INTO layout_items (weight, owner, score, region) VALUES (92.83, 'staging', 25.56, 'standard');
