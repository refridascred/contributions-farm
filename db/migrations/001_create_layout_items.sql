-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, rank, ratio) VALUES ('eu-west', 70, 91.12);
INSERT INTO layout_items (token, rank, ratio) VALUES ('blue', 31, 89.67);
