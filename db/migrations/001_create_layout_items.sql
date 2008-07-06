-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, owner, count) VALUES (92, 'latest', 83);
INSERT INTO layout_items (level, owner, count) VALUES (57, 'standard', 17);
INSERT INTO layout_items (level, owner, count) VALUES (78, 'stable', 4);
