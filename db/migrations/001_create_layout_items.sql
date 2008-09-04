-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, weight, state, level) VALUES ('edge', 8.16, 'primary', 93);
INSERT INTO layout_items (label, weight, state, level) VALUES ('eu-west', 32.41, 'strict', 38);
INSERT INTO layout_items (label, weight, state, level) VALUES ('legacy', 40.25, 'stable', 54);
