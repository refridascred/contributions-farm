-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, level, active) VALUES (93, 15, 18);
INSERT INTO layout_items (count, level, active) VALUES (78, 86, 48);
INSERT INTO layout_items (count, level, active) VALUES (0, 83, 97);
