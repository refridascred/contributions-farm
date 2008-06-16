-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, token) VALUES (37.89, 'blue');
INSERT INTO layout_items (weight, token) VALUES (74.56, 'blue');
INSERT INTO layout_items (weight, token) VALUES (26.27, 'standard');
