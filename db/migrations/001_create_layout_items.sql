-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight) VALUES ('primary', 27.24);
INSERT INTO layout_items (token, weight) VALUES ('cached', 73.67);
INSERT INTO layout_items (token, weight) VALUES ('latest', 84.7);
