-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, rank, weight) VALUES ('green', 94, 27.55);
INSERT INTO layout_items (token, rank, weight) VALUES ('stable', 3, 54.37);
INSERT INTO layout_items (token, rank, weight) VALUES ('cached', 96, 80.03);
