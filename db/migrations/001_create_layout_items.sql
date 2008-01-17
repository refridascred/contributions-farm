-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, weight) VALUES (14, 5.53);
INSERT INTO layout_items (level, weight) VALUES (74, 53.24);
INSERT INTO layout_items (level, weight) VALUES (33, 94.48);
