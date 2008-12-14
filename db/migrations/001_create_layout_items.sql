-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, active, score, weight, owner) VALUES ('primary', 74, 60.36, 86.41, 'strict');
INSERT INTO layout_items (token, active, score, weight, owner) VALUES ('standard', 29, 81.37, 40.98, 'open');
INSERT INTO layout_items (token, active, score, weight, owner) VALUES ('standard', 89, 11.27, 94.98, 'strict');
