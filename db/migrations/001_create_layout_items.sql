-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (score, owner, level, active) VALUES (6.58, 'strict', 99, 22);
INSERT INTO layout_items (score, owner, level, active) VALUES (5.12, 'eu-west', 78, 82);
INSERT INTO layout_items (score, owner, level, active) VALUES (40.41, 'strict', 20, 48);
