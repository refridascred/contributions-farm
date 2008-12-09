-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, active, score, owner) VALUES (1.42, 29, 21.76, 'staging');
INSERT INTO layout_items (weight, active, score, owner) VALUES (84.53, 54, 98.67, 'eu-west');
INSERT INTO layout_items (weight, active, score, owner) VALUES (86.01, 85, 94.55, 'fallback');
