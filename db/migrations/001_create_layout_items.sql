-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, state, score, active, weight) VALUES (62, 'primary', 74.35, 22, 49.56);
INSERT INTO layout_items (level, state, score, active, weight) VALUES (9, 'staging', 79.46, 66, 6.88);
INSERT INTO layout_items (level, state, score, active, weight) VALUES (60, 'eu-west', 40.71, 36, 57.42);
