-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, weight) VALUES (19, 54.88);
INSERT INTO layout_items (count, weight) VALUES (38, 20.96);
INSERT INTO layout_items (count, weight) VALUES (0, 5.67);
