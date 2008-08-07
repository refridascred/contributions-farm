-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, rank, score, ratio) VALUES ('standard', 77, 18.23, 9.24);
INSERT INTO layout_items (owner, rank, score, ratio) VALUES ('standard', 19, 64.1, 10.82);
