-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, ratio, score) VALUES ('cached', 80.86, 8.87);
INSERT INTO layout_items (owner, ratio, score) VALUES ('cached', 24.53, 29.28);
