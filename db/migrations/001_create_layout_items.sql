-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, owner, level) VALUES (96.86, 'edge', 2);
INSERT INTO layout_items (ratio, owner, level) VALUES (75.24, 'local', 85);
