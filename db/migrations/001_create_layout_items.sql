-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, ratio, level, token, weight) VALUES ('primary', 35.67, 61, 'local', 9.1);
INSERT INTO layout_items (state, ratio, level, token, weight) VALUES ('standard', 2.85, 24, 'local', 80.57);
