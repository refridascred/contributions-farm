-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, owner, rank, token, ratio) VALUES (69.62, 'blue', 64, 'edge', 10.61);
INSERT INTO layout_items (weight, owner, rank, token, ratio) VALUES (13.7, 'open', 28, 'legacy', 36.01);
INSERT INTO layout_items (weight, owner, rank, token, ratio) VALUES (36.16, 'local', 90, 'eu-west', 84.58);
