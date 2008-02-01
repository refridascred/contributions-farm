-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, score, state, label, active) VALUES (12.01, 64.21, 'green', 'strict', 76);
INSERT INTO layout_items (weight, score, state, label, active) VALUES (95.95, 31.99, 'open', 'fallback', 65);
