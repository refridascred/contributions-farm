-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, ratio, weight, token, rank) VALUES ('open', 24.31, 80.71, 'green', 92);
INSERT INTO layout_items (owner, ratio, weight, token, rank) VALUES ('fallback', 3.49, 55.37, 'cached', 92);
