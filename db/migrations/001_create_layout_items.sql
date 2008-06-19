-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, level) VALUES (1.23, 58);
INSERT INTO layout_items (weight, level) VALUES (60.74, 25);
INSERT INTO layout_items (weight, level) VALUES (87.13, 63);
