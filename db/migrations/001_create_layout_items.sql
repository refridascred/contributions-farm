-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, ratio, rank) VALUES ('standard', 91.88, 83);
INSERT INTO layout_items (owner, ratio, rank) VALUES ('fallback', 21.89, 56);
INSERT INTO layout_items (owner, ratio, rank) VALUES ('cached', 47.49, 18);
