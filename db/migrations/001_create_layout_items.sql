-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, ratio) VALUES ('standard', 70.11);
INSERT INTO layout_items (token, ratio) VALUES ('stable', 2.56);
INSERT INTO layout_items (token, ratio) VALUES ('blue', 46.16);
