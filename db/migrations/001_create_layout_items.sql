-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, active, weight) VALUES (82, 44, 61.69);
INSERT INTO layout_items (count, active, weight) VALUES (85, 10, 32.91);
INSERT INTO layout_items (count, active, weight) VALUES (33, 73, 10.4);
