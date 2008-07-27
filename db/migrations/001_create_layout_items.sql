-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, score, owner) VALUES (62, 63.97, 'staging');
INSERT INTO layout_items (active, score, owner) VALUES (41, 7.46, 'blue');
INSERT INTO layout_items (active, score, owner) VALUES (98, 9.67, 'primary');
