-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, region, level, owner) VALUES (95.88, 'green', 80, 'cached');
INSERT INTO layout_items (weight, region, level, owner) VALUES (59.01, 'edge', 11, 'local');
INSERT INTO layout_items (weight, region, level, owner) VALUES (19.43, 'staging', 71, 'standard');
