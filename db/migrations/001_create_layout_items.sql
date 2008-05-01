-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, active, state, count, weight) VALUES ('eu-west', 47, 'staging', 81, 31.86);
INSERT INTO layout_items (token, active, state, count, weight) VALUES ('fallback', 88, 'strict', 89, 45.66);
INSERT INTO layout_items (token, active, state, count, weight) VALUES ('legacy', 83, 'primary', 13, 87.57);
