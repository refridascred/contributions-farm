-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, owner, rank, weight) VALUES (52.28, 'green', 64, 51.0);
INSERT INTO layout_items (ratio, owner, rank, weight) VALUES (98.28, 'eu-west', 33, 61.38);
