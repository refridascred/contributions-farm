-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, owner, weight, region) VALUES (94.45, 'stable', 90.47, 'local');
INSERT INTO layout_items (ratio, owner, weight, region) VALUES (10.64, 'blue', 49.52, 'fallback');
INSERT INTO layout_items (ratio, owner, weight, region) VALUES (61.68, 'stable', 85.3, 'local');
