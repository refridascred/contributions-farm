-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, region, active, owner) VALUES ('eu-west', 'blue', 21, 'staging');
INSERT INTO layout_items (state, region, active, owner) VALUES ('stable', 'green', 7, 'local');
INSERT INTO layout_items (state, region, active, owner) VALUES ('blue', 'latest', 81, 'eu-west');
