-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (score, ratio, owner) VALUES (26.83, 47.24, 'primary');
INSERT INTO layout_items (score, ratio, owner) VALUES (26.9, 10.01, 'latest');
INSERT INTO layout_items (score, ratio, owner) VALUES (19.35, 32.74, 'standard');
