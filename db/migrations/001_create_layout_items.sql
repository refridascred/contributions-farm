-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, rank, ratio, token, count) VALUES (92, 4, 74.17, 'eu-west', 13);
INSERT INTO layout_items (active, rank, ratio, token, count) VALUES (39, 45, 87.21, 'local', 3);
INSERT INTO layout_items (active, rank, ratio, token, count) VALUES (10, 0, 12.69, 'eu-west', 93);
