-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, state, active, weight, owner) VALUES ('local', 'strict', 95, 43.09, 'primary');
INSERT INTO layout_items (region, state, active, weight, owner) VALUES ('latest', 'primary', 83, 55.91, 'fallback');
