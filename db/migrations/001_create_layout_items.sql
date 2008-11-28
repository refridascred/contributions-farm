-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, rank, owner, region) VALUES (44.81, 56, 'local', 'primary');
