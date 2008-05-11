-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, score) VALUES (0.23, 23.51);
INSERT INTO layout_items (weight, score) VALUES (4.52, 79.68);
INSERT INTO layout_items (weight, score) VALUES (11.26, 22.95);
