-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, token, weight, level, active) VALUES ('legacy', 'latest', 53.45, 77, 21);
INSERT INTO layout_items (state, token, weight, level, active) VALUES ('local', 'staging', 55.03, 43, 8);
