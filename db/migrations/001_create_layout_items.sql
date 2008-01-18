-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, active, ratio, owner, score) VALUES (10.44, 41, 17.71, 'staging', 62.16);
INSERT INTO layout_items (weight, active, ratio, owner, score) VALUES (75.62, 76, 7.36, 'green', 20.63);
INSERT INTO layout_items (weight, active, ratio, owner, score) VALUES (90.24, 99, 93.07, 'staging', 17.96);
