-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, owner, ratio, rank) VALUES ('green', 'edge', 82.89, 71);
INSERT INTO layout_items (token, owner, ratio, rank) VALUES ('strict', 'blue', 15.53, 65);
INSERT INTO layout_items (token, owner, ratio, rank) VALUES ('staging', 'standard', 61.73, 2);
