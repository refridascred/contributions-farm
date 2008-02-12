-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, level, active, state) VALUES (29.06, 80, 59, 'open');
INSERT INTO layout_items (weight, level, active, state) VALUES (16.88, 74, 78, 'standard');
INSERT INTO layout_items (weight, level, active, state) VALUES (27.74, 7, 70, 'primary');
