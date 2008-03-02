-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, ratio, level) VALUES ('staging', 29.58, 70);
INSERT INTO layout_items (state, ratio, level) VALUES ('primary', 75.64, 42);
INSERT INTO layout_items (state, ratio, level) VALUES ('standard', 1.94, 50);
