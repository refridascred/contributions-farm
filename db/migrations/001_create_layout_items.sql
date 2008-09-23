-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, token) VALUES (23.25, 'staging');
INSERT INTO layout_items (ratio, token) VALUES (59.99, 'staging');
INSERT INTO layout_items (ratio, token) VALUES (27.23, 'green');
