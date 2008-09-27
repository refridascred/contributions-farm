-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, owner, count) VALUES (61.19, 'latest', 84);
INSERT INTO layout_items (ratio, owner, count) VALUES (51.82, 'primary', 60);
INSERT INTO layout_items (ratio, owner, count) VALUES (92.67, 'staging', 83);
