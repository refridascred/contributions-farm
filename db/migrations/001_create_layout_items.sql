-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, ratio, owner, region) VALUES (69, 66.19, 'cached', 'latest');
INSERT INTO layout_items (level, ratio, owner, region) VALUES (27, 35.11, 'primary', 'standard');
