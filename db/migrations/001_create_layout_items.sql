-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, token, count) VALUES (90, 'stable', 60);
INSERT INTO layout_items (level, token, count) VALUES (85, 'blue', 0);
INSERT INTO layout_items (level, token, count) VALUES (69, 'cached', 43);
