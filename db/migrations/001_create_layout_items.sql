-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, count) VALUES (41, 42);
INSERT INTO layout_items (level, count) VALUES (93, 53);
INSERT INTO layout_items (level, count) VALUES (53, 54);
