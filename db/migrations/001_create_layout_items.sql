-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, label, rank, owner, token) VALUES (2.17, 'latest', 97, 'eu-west', 'legacy');
INSERT INTO layout_items (weight, label, rank, owner, token) VALUES (6.46, 'blue', 36, 'primary', 'fallback');
INSERT INTO layout_items (weight, label, rank, owner, token) VALUES (87.73, 'primary', 49, 'open', 'green');
