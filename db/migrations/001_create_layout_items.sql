-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, score, owner) VALUES (14, 63.32, 'staging');
INSERT INTO layout_items (level, score, owner) VALUES (79, 43.79, 'standard');
INSERT INTO layout_items (level, score, owner) VALUES (78, 85.26, 'green');
