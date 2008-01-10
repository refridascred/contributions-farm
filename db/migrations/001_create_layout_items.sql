-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region) VALUES (8.85, 'local');
INSERT INTO layout_items (score, region) VALUES (58.85, 'local');
INSERT INTO layout_items (score, region) VALUES (76.7, 'latest');
