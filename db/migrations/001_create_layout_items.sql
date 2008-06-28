-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, owner, ratio, weight) VALUES ('blue', 'local', 14.49, 18.48);
INSERT INTO layout_items (state, owner, ratio, weight) VALUES ('fallback', 'latest', 52.72, 94.18);
INSERT INTO layout_items (state, owner, ratio, weight) VALUES ('local', 'staging', 38.3, 10.69);
