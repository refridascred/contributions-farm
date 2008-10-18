-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, count) VALUES (50.04, 12);
INSERT INTO layout_items (weight, count) VALUES (19.86, 73);
INSERT INTO layout_items (weight, count) VALUES (30.73, 81);
