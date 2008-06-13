-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, level, ratio, owner) VALUES ('local', 33, 16.71, 'green');
INSERT INTO layout_items (region, level, ratio, owner) VALUES ('staging', 92, 75.71, 'latest');
