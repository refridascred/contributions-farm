-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, weight, owner, count) VALUES (71, 46.6, 'local', 4);
INSERT INTO layout_items (active, weight, owner, count) VALUES (87, 11.1, 'green', 44);
INSERT INTO layout_items (active, weight, owner, count) VALUES (44, 37.93, 'cached', 11);
