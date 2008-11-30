-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, region, owner) VALUES (26.37, 'legacy', 'eu-west');
INSERT INTO layout_items (ratio, region, owner) VALUES (15.97, 'stable', 'latest');
