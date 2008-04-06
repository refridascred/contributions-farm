-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, weight, count, active) VALUES ('eu-west', 25.96, 92, 7);
INSERT INTO layout_items (state, weight, count, active) VALUES ('local', 78.91, 91, 63);
INSERT INTO layout_items (state, weight, count, active) VALUES ('open', 79.91, 31, 16);
